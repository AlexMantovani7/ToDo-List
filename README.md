# ToDo-List
---------- O Projeto ------------------------------
 Um projeto redigido em C# através do Visual Studio e MySql, o projeto tem como objetivo Criar, Testar e Manter uma ToDo List que gerenciará as tarefas e deadlines do Usuário.

---------- Diagramas ------------------------------
 Contido no diretório GitHub do Projeto ToDo-List, é possivel encontrar o arquivo "Diagramas ToDo_List.asta" que contem um simples diagrama de Casos de Uso criado com a ferramenta Astah Community, uma ferramenta excelente para montagem de varios tipos de diagramas bases para criação de projetos.
 
---------- Arquivo Instalação MySql ---------------
 Seguindo para o diretório "DataBase CreateScript", uma pasta que contem 4 scripts para a criação da Base de dados, Procedures, Views e afins. Exercute a instalação da Base de Dados MySql e salve as insformações ultilezadas nos campos server (127.0.0.1 por padrão), Uid (seu nome de usuário) e pwd (sua senha) pois serão importantes.

---------- Executando Scripts MySql ---------------
 Após instalação, basta prosseguir com a execução do scripts de criação contidos na pasta "DataBase CreateScript", em ordem númerica sendo 1 criando a Base de Dados e tabelas, 2 criando seus Procedures, 3 com as Views das tabales agilizam no momento de contar Selects para Consulta, e 4 finalizando com as Procedures de Consulta.

---------- String Conexão -------------------------
 Com isso o sistema está quase completo para sua ultilização total, só faltará monificar sua string de conexão com o server, Uid e o pwd criados durante a instalação do Banco, basta abrir a classe "DataBase_Control" contida na Camada(diretório) de DataAccess_Layer. Nesta, vá até a função "CreateConnection" e lá encontrará os campos para inserir seus dados, mas mantenha o "database=todoList" pois ele representa o banco criado pelos Scripts.

---------- IDE ou Instalação ----------------------
Executando pela IDE, a API já pode ser usufluida normalmente, mas caso desejar, tambem há a opção de gerar um executavel para instalação, através do "Setup Wizard" já pré configurado, basta recompilar o projeto "ToDo-List_Setup" para que ele gere a pasta de mesmo nome com o arquivo executavel atualizado com suas mudanças da string da conexão.

---------- Modo de Uso API ------------------------
A aplicação é extremamente facil e intuitiva de se ultilizar, existe 2 Abas, uma com a Lista com suas Tarefas, e outra com campos com as informações detalhadas da tarefa selecionada onde fica facil a visualização e a manipulação dessas informações. Além disso, na partido superior existe todas as ferramentas que se pode interagir como Botões de "Cadastar" e "Alterar" suas Tarefas, "Deletar" para eliminar metas já alcançadas, "Completar" para sinalizar que aquela tarefa concluida com sucesso e "Encerrar" para sinalizar que aquela tarefa não pode ou não foi concluida.
A tabela também recebe diversas colorações dependendo do processo que se encontra determinada tarefa sendo Verde para concluida, Amarelo para Realizando, Branco para Esperando a Data de inicio e Vermelho para prazos estourados e linhas marcadas como Encerradas.
Os sistemas de pesquisa são muito práticos com Calendario retrateis para facilitar na hora de selecionar uma data para iniciar e finalizar as tarefas, e uma janelas de pesquisa que trará as linhas que você precisa.

---------- Agradecimentos ------------------------
Muito obrigado pela oportunidade e também por ter a chance de desenvolver mais um sistema que é sempre muito bem vindo.