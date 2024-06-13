-- --------------------------------CRIANDO PROCEDURES----------------------------------
USE ToDoList;

-- TASK -------------------------------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE sp_ManageTask(
	IN var_operation CHAR(9), -- CADASTRO, ALTERACAO, REMOCAO
    IN var_codeTask INT,
    IN var_priority VARCHAR(5), -- Alta ou Baixa
    IN var_descriptionTask VARCHAR(50),
    IN var_detailsTask VARCHAR(150),
    IN var_initial_date DATETIME,
    IN var_final_date DATETIME,
    IN var_task_progress VARCHAR(10) -- Esperando, Realizando, Concluido ou Cancelado. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
)
BEGIN
	
	DECLARE var_commit_control TINYINT DEFAULT TRUE;		-- Cria uma var_commit_control que vai ser usada para check se o commit pode ser realizado, ou dar rollback em um erro.
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET var_commit_control = FALSE;		-- Caso haja um erro na execução, a var_commit_control receberá FALSE para acionar o rollback.
    
    SET @@AUTOCOMMIT = OFF;	-- Desliga o commit automatico para que o "Try, Catch e rollback" possa funcionar corretamente e commitar manualmente.
    
    IF ( (var_codeTask IS NULL) OR (var_priority IS NULL) OR (var_descriptionTask IS NULL) OR (var_detailsTask IS NULL) OR (var_initial_date IS NULL) OR (var_final_date IS NULL) OR (var_task_progress IS NULL) ) THEN
		SELECT CONCAT('A informação está NULL ou Inválida. \r\n ', 
        '\r\n CAMPO Código: ( ', IFNULL(var_codeTask, 'NULL'), ' )',
        '\r\n CAMPO Prioridade: ( ', IFNULL(var_priority, 'NULL'), ' )',
        '\r\n CAMPO Descrição: ( ', IFNULL(var_descriptionTask, 'NULL'), ' )',
        '\r\n CAMPO Detalhes: ( ', IFNULL(var_detailsTask, 'NULL'), ' )',
        '\r\n CAMPO Data Inicial: ( ', IFNULL(var_initial_date, 'NULL'), ' )',
        '\r\n CAMPO Data Final: ( ', IFNULL(var_final_date, 'NULL'), ' )',
        '\r\n CAMPO Progresso Tarefa: ( ', IFNULL(var_task_progress, 'NULL'), ' )'
        ) AS 'ALERTA';
	
    ELSE
        
        IF ( (var_operation = 'CADASTRO') OR (var_operation = 'ALTERACAO') OR (var_operation = 'REMOCAO') ) THEN
        
-- -----CADASTRO ------------------------------------------------------------------------------------------------------------------------------------------------
			IF (var_operation = 'CADASTRO') THEN
                
                START TRANSACTION;	-- Inicia as transações que receberam rollback caso haja algum erro que prejudique a sintax.
                
                INSERT INTO tbl_Task
                (codeTask, priority, descriptionTask, detailsTask, initial_date, final_date, task_progress)
                VALUES
                (var_codeTask, var_priority, var_descriptionTask, var_detailsTask, var_initial_date, var_final_date, var_task_progress);
                
                SELECT MAX(t.codeTask)
                INTO var_codeTask
                FROM tbl_Task AS t LIMIT 1;
                
                -- Se o processo foi um sucesso, a variavel var_commit_control estará TRUE e poderá realizar o commit;
                IF ( var_commit_control ) THEN
					COMMIT;
                    SELECT var_codeTask AS 'SUCESSO';
				ELSE
					ROLLBACK;
					SELECT 'Erro na transação de dados, operação não pode ser realizada.' AS 'ALERTA';
				END IF;
                            
-- -----ALTERAÇÃO ------------------------------------------------------------------------------------------------------------------------------------------------
			ELSEIF ( (var_operation = 'ALTERACAO') ) THEN
				
                IF( var_codeTask > 0 ) THEN
					
                    START TRANSACTION;	-- Inicia as transações que receberam rollback caso haja algum erro que prejudique a sintax.
                    
                    UPDATE tbl_Task
                    SET
                    codeTask = var_codeTask,
                    priority = var_priority,
                    descriptionTask = var_descriptionTask,
                    detailsTask = var_detailsTask,
                    initial_date = var_initial_date,
                    final_date = var_final_date,
                    task_progress = var_task_progress
                    WHERE
                    codeTask = var_codeTask;
                    
                    -- Se o processo foi um sucesso, a variavel var_commit_control estará TRUE e poderá realizar o commit;
                    IF ( var_commit_control ) THEN
						COMMIT;
                        SELECT var_codeTask AS 'SUCESSO';
					ELSE
						ROLLBACK;
                        SELECT 'Erro na transação de dados, operação não pode ser realizada.' AS 'ALERTA';
					END IF;
				
                ELSE
					SELECT 'A operação requisitada não pode ser realizada pois o Código informado não é válido.' AS 'ALERTA';
				END IF;

-- -----REMOÇÃO ------------------------------------------------------------------------------------------------------------------------------------------------
			ELSEIF (var_operation = 'REMOCAO') THEN
				
                IF( var_codeTask > 0 ) THEN
					
                    START TRANSACTION;	-- Inicia as transações que receberam rollback caso haja algum erro que prejudique a sintax.
                    
                    DELETE FROM tbl_Task
                    WHERE
                    codeTask = var_codeTask;
                    
                    -- Se o processo foi um sucesso, a variavel var_commit_control estará TRUE e poderá realizar o commit;
                    IF ( var_commit_control ) THEN
						COMMIT;
                        SELECT var_codeTask AS 'SUCESSO';
					ELSE
						ROLLBACK;
                        SELECT 'Erro na transação de dados, operação não pode ser realizada.' AS 'ALERTA';
					END IF;
				
                ELSE
					SELECT 'A operação requisitada não pode ser realizada pois o Código informado não é válido.' AS 'ALERTA';
				END IF;
		
-- -----CASO NÃO TENHA INSERIDO NENHUMA OPERAÇÃO ----------------------------------------------------------------------------------------------------------------
			ELSE
				SELECT CONCAT('A operação ( ', IFNULL(var_operation, 'NULL'), ' ) não é VÁLIDA.') AS 'ALERTA';
			END IF;
        
        ELSE
            SELECT CONCAT( 'A operação informada não é válida: ( ', IFNULL(var_operation, 'NULL'), ' ).' ) AS 'ALERTA';
		END IF;
		
	END IF;
    
END $$
DELIMITER ;