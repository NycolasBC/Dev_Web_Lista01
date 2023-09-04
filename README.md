# Dev_Web_Lista01
Lista 1 e 2 de atividade de Desenvolvimento Web - 4° Período Uniaraxá

<div>
    <h1>Lista 1 de atividades:</h1>
    <h3>Questão 1: Diferencie front end e backend. Cite duas tecnologias em cada uma delas.</h3>
      <p>- Front-end: É a parte visual e interativa que os usuários interagem diretamente. Tecnologias: HTML e CSS</p>
      <p>- Back-end: É a parte do sistema que lida com o gereciamento de informações, processamento de dados e a parte lógica. Tecnologias: NodeJS e ASP.NET   Core</p>  
  <br>
  <br>
    <h3>Questão 2: Nos conceitos estudados em aula, falamos sobre controller e models. Responda:</h3>
      <h4>a) Defina o papel de cada um e responda por que ao criarmos nosso controller fizemos uma herança de controllerbase?</h4>
        <p>- Controllers: É responsável por receber as solicitações do cliente, processar essas solicitações e coordenar ações apropriadas para retornar uma resposta</p>
        <p>- Models: São responsáveis por definir como os dados são organizados, armazenados e manipulados</p>
        <p>Fizemos a herança pois com ele teremos acessos aos recursos base de um controller, como: Atributos de rastreamento e filtro e Métodos de ação e rastreamento</p>
      <h4>b) Em sala, mostramos que ao abrir um nagevador conseguimos chamar uma rota GET e POST não , explique por que só conseguimos executar a Rota GET no browser.</h4>
        <p>A capacidade de chamar uma rota GET diretamente no navegador é devido à natureza da solicitação GET, que busca informações do servidor. No entanto, as solicitações POST são projetadas para enviar dados ao servidor e, portanto, não podem ser executadas diretamente digitando uma URL na barra de endereços do navegador.</p>
      <h4>c) Qual o papel do Swagger, por que utilizamos ele?</h4>
        <p>O Swagger é uma ferramenta de código aberto que é usada para documentar, testar e visualizar APIs de forma fácil e interativa. Utilizamos ele pois ele descreve as APIs em um formato legível por máquina e humano, permitindo que desenvolvedores, equipes de teste e outros stakeholders compreendam as funcionalidades da API sem precisar analisar o código-fonte diretamente.</p>
  <br>
  <br>
    <h3>Questão 3: Dadas ações cite o verbo http correto para utilizarmos, considere ações no AVA do uniaraxá:</h3>
      <p>a) Criar a aula: POST</p>
      <p>b) Remover um material: DELETE</p>
      <p>c) Listar as disciplinas disponíveis para o professor no semestre: GET</p>
      <p>d) Listas os alunos da disciplina: GET</p>
      <p>e) Atualizar um material: PUT/PATCH</p>
      <p>f) Lançar uma nota: POST</p>
  <br>
  <br>
    <h3>Questão 4: Em sala mostramos que ao fazer um return da action utilizamos um Status Http , por exemplo,
Ok(), BadRequest(), NotFound() , entre outros. Especifique a diferença de cada um.</h3>
      <p>- Ok(): Usado para indicar que uma solicitação foi bem-sucedida. Retorna status HTTP 200</p>
      <p>- BadRequest(): Usado para indicar que uma solicitação é inválida ou malformada. Retorna status HTTP 400</p>
      <p>- NotFound(): Usado para indicar que um recurso não foi encontrado. Retorna status HTTP 404</p>
  <br>
  <br>
    <h3>Questão 5: A seguir , temos um exemplo de endpoint de API: <a>https://minhaapi.com.br/api/vendas</a>. Explique cada parte:</h3>
      <p>• https://: Indica que a comunicação entre o cliente (navegador) e o servidor (API) é criptografada</p>
      <p>• minhaapi.com.br: É o domínio da API. O domínio é o endereço principal que os usuários utilizam para acessar uma aplicação web ou uma API</p>
      <p>• /api/vendas: São as rotas da api. É a parte do caminho do URL que especifica o recurso que está sendo acessado na API</p>
</div>
<br>
<br>
<br>
<br>
<div>
    <h1>Lista 2 de atividades:</h1>
    <h3>Questão 1: Descreva 3 importantes motivos para validarmos os dados em nossa API.</h3>
      <p>Segurança, Integridade dos Dados e Prevenção de Erros Lógicos</p>
  <br>
  <br>
    <h3>Questão 2: Considere as seguintes entidades, descreva quais as validações você faria e como faria:</h3>
      <h4>a)	Cenário 1: Cadastro de cliente com:</h4>
        <p>Nome: validação de tamanho de string e obrigatório. Utilizaria o data annotation</p>
        <p>CPF: validação da receita e obrigatório. Utilizaria um data annotation personalizado</p>
        <p>Data Nascimento: validação que verifica idade. Utilizaria o data annotation</p>
        <p>Email: validação de formato e verificar se é único. Utilizaria o data annotation</p>
        <p>Telefone: validação de formato e verificar se é único. Utilizaria o data annotation</p>
        <p>Senha: validação para que a senha contenha alguns critérios.</p>
        <p>Cep, Rua, Bairro, Cidade, Estado: verificação de formato e se o lugar existe.</p>
  <br>
      <h4>b)	Cenário 2: Cadastro de Disciplina:</h4>
        <p>Nome: validação de tamanho de string e obrigatório. Utilizaria o data annotation</p>
        <p>Carga Horária: validação de tipo. Utilizaria o data annotation</p>
        <p>Objetivo: validação de tamanho de string. Utilizaria o data annotation</p>
        <p>Ementa: validação de tamanho de string. Utilizaria o data annotation</p>
        <p>Semestre: validação para verificar se está dentro de uma faixa válida</p>
        <p>Ano: validação de tipo. Utilizaria o data annotation</p>
        <p>Nome Professor: validação de tamanho de string e obrigatório. Utilizaria o data annotation</p>
  <br>
  <br>
    <h3>Questão 3: Em sala mostramos as validações utilizando inicialmente “o bom e velho if/else”, porém falamos que esse processo pode conter vantagens e desvantagens, por isso, mostramos depois o data annotation. Descreva comparando as duas técnicas apresentando vantagens e desvantagens.</h3>
    <p>O if/else lhe permite uma flexiblidade maior em relação as validações. Mas como se trata de uma validação manual, quando tiver muitas validações a serem feitas se torna inviável sua utilização</p>
    <p>O Data Annotations é simples de usar e diminui a quantidade de códigos a ser utilizado, mas sua flexibilidade não é tão boa, limitando-se a regras simples.</p>
  <br>
  <br>
    <h3>Questão 4: Em sala mostramos que ao usar o data annotation, quando um dado é invalidado, ele não “chamava” a action e já retornava o “error message”. Descreva o que acontecia nesse caso que ele automaticamente já validava e não caia no debug da action?</h3>
      <p>O .Net consegue realizar um filtro que automaticamente valida os dados de acordo com os tipos dele. Sendo assim, quando estiverem incorretos ele automaticamente já faz uma validação.</p>
</div>
