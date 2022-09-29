# FL ADT CHALLENGE v1

<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print1.gif?raw=true">
     
</br>

# DESCRIÇÃO DO DESAFIO

Com base no CSV em anexo, construa uma solução que receba uma hora do dia como input no formato HH:MM, sendo HH entre 1 e 24 e MM entre 00 e 60, e retorne uma lista com os nomes dos restaurantes que estão abertos nessa hora. Você tem autonomia para escolher os padrões do projeto, organização de arquivos e pastas, tipo da solução (API, console, MVC, microsserviço, etc).

Atenção: O CSV em anexo não é simplesmente a estrutura que dita como será mapeado a sua classe de Restaurant, a aplicação deve ser capaz de ler e interpretar um arquivo CSV. Não precisa se preocupar com time zones, vamos supor que todas as horas são locais.
O time espera que você entregue os requisitos mínimos:

1. Funcionar (recomendamos usar o Docker para simular sistemas operacionais diferentes);
2. Suíte de testes unitários que sejam relevantes (Xunit, Moq);
3. README explicando como funciona o projeto e o porquê das suas escolhas.

O que será avaliado:

1. Qualidade do código (funcionalidade, manutenibilidade, desempenho);
2. Algoritmo;
3. Arquitetura;
4. Testes de unidade;
5. Utilização do Git.

O desafio deve ser entregue usando o Framework .NET Core 3.1 ou superior em um repositório público do Github para que o time possa avaliar a qualidade da sua entrega.!
</br>
</br>
# INSTRUÇÕES PARA EXECUÇÃO
</br>
Execute a aplicação e abra a documentação (Swagger), logo após carregar a página, click no botão 'GET', conforme a imagem abaixo:
<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print2.gif">
Em seguida, click em 'Try it out':
<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print3.gif">
Nessa etapa, no campo 'HourMinute', informe Horas e minutos:
<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print4.gif">
Click em 'Execute' para realizar a consulta.
<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print5.gif">
O resultado será apresentado logo abaixo, semelhante a seguinte imagem:
<img src="https://github.com/ssj4dofuturo/FL_ADT_CHALLENGE/blob/main/docs/material/print6.gif">
</br>
</br>

# ESCOLHAS

- Arquitetura, escolhi arquitetura cebola (Onion Architecture), dividindo minha aplicação em camadas: Presentarion, Core, Infra e Tests. </br>
- A escolha no .net core 3.1 foi seguindo o descrito na descrição do desafio, e por minha familiaridade com essa versão do framework. </br>
- Escolhi usar back-end usando Web API. Para esse desafio, a criação de uma API e a documentação dela (Swagger) facilitaria e simplificaria a solução. </br>


<i><h6>Todos os direitos reservados. O autor permite apenas a visualização do código, sendo proibida qualquer utilização do mesmo, no todo ou em parte.</h6></i>
