CREATE DATABASE IF NOT EXISTS ToDoList;

USE ToDoList;

-- --------------------------------CRIANDO AS TABELAS BASE----------------------------------
CREATE TABLE tbl_Task(
	codeTask INT AUTO_INCREMENT PRIMARY KEY,
    priority VARCHAR(5) NOT NULL, -- Alta ou Baixa
    descriptionTask VARCHAR(50) NOT NULL,
    detailsTask VARCHAR(150) NOT NULL,
    initial_date DATETIME NOT NULL,
    final_date DATETIME NOT NULL,
    task_progress VARCHAR(10) NOT NULL -- Esperando, Realizando, Concluido ou Cancelado. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
);