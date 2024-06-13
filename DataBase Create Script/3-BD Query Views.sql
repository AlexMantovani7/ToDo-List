-- --------------------------------CRIANDO VIEWs----------------------------------
USE ToDoList;

-- TASK -------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE VIEW vw_Task AS
SELECT
	t.codeTask,
    t.priority, -- Alta ou Baixa
    t.descriptionTask,
    t.detailsTask,
    t.initial_date,
    t.final_date,
    t.task_progress -- Esperando, Realizando, Concluido ou Cancelado. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
FROM tbl_Task AS t