

Descrição da API - Sistema de Filmes, Cinemas e Sessões
Esta API é um sistema completo para gerenciamento de filmes, cinemas e sessões de exibição. Desenvolvida utilizando Entity Framework, MySqlWorkbench, CRUD completo, AutoMapper e Newtonsoft.Json, ela oferece uma solução robusta e flexível para organizar e relacionar informações sobre filmes, cinemas e suas respectivas sessões.

Recursos Principais
Filmes: Crie, edite, liste e remova informações sobre filmes. Cada filme possui detalhes como título, descrição, gênero, diretor, elenco e classificação indicativa.

Cinemas: Gerencie informações sobre os cinemas, incluindo nome, endereço, capacidade e horários de funcionamento.

Sessões: Estabeleça sessões de exibição para os filmes em cada cinema. Cada sessão possui data, horário, preço do ingresso e disponibilidade de assentos.

Relacionamentos
Relação 1:N: Os filmes podem estar relacionados com vários cinemas, indicando onde estão sendo exibidos. Um cinema pode exibir vários filmes em diferentes sessões.

Relação N:N: Os filmes podem ser exibidos em várias sessões em diferentes horários e em diferentes cinemas. Da mesma forma, uma sessão pode exibir diferentes filmes em horários específicos.

Tecnologias Utilizadas
Entity Framework: Utilizado para mapeamento objeto-relacional, facilitando a interação com o banco de dados.

MySqlWorkbench: Ferramenta de modelagem de banco de dados utilizada para criar e gerenciar a estrutura do banco de dados MySQL.

CRUD Completo: Implementação das operações CRUD (Create, Read, Update, Delete) para todas as entidades, garantindo o controle completo sobre os dados.

AutoMapper: Utilizado para mapeamento de objetos, facilitando a conversão entre modelos de dados.

Newtonsoft.Json: Biblioteca para serialização e desserialização de objetos JSON, facilitando a comunicação entre o frontend e o backend.

Esta API fornece uma base sólida para desenvolver aplicativos de gerenciamento de cinema, sistemas de reserva de ingressos, entre outros. Fique à vontade para explorar a documentação e começar a integrá-la aos seus projetos!
