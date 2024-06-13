-- --------------------------------CRIANDO PROCEDURES DE CONSULTA DE DADOS USANDO AS VIEWs----------------------------------
USE ToDoList;

-- TASK -------------------------------------------------------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE sp_ConsultTask(
    IN var_searchAll BOOLEAN,
    IN var_codeTask INT,
    IN var_priority VARCHAR(5), -- Alta ou Baixa
    IN var_descriptionTask VARCHAR(50),
    IN var_detailsTask VARCHAR(150),
    IN var_initial_date DATETIME,
    IN var_final_date DATETIME,
    IN var_task_progress VARCHAR(10) -- Esperando, Realizando, Concluido ou Cancelado. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
)
BEGIN
	DECLARE var_commit_control TINYINT DEFAULT TRUE;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET var_commit_control = FALSE;
    
    SET @@AUTOCOMMIT = OFF;

-- -----BUSCAR TODOS ------------------------------------------------------    
    IF (var_searchAll) THEN
		
        START TRANSACTION;
				
		SELECT * FROM vw_Task AS t
        ORDER BY t.codeTask DESC;
		
        IF ( var_commit_control ) THEN
			COMMIT;
		ELSE
			ROLLBACK;
			SELECT 'Não foi possivel realizar a consulta do registro.' AS 'ALERTA';
		END IF;

-- -----BUSCA ESPECIFICA --------------------------------------------------	
    ELSE
        START TRANSACTION;
        
        SELECT * FROM vw_Task AS t
		WHERE
        ((t.codeTask = var_codeTask) OR (var_codeTask IS NULL)) AND
        ((t.priority LIKE CONCAT(var_priority, '%')) OR (var_priority IS NULL)) AND
        ((t.descriptionTask LIKE CONCAT(var_descriptionTask, '%')) OR (var_descriptionTask IS NULL)) AND
		((t.detailsTask LIKE CONCAT(var_detailsTask, '%')) OR (var_detailsTask IS NULL)) AND
        ((t.initial_date = var_initial_date) OR (var_initial_date IS NULL)) AND
		((t.final_date = var_final_date) OR (var_final_date IS NULL)) AND
        ((t.task_progress LIKE CONCAT(var_task_progress, '%')) OR (var_task_progress IS NULL))
        ORDER BY t.descricao_Material ASC;
		
        IF ( var_commit_control ) THEN
			COMMIT;
		ELSE
			ROLLBACK;
			SELECT 'Não foi possivel realizar a consulta do registro.' AS 'ALERTA';
		END IF;
		
    END IF;
    
END $$
DELIMITER ;