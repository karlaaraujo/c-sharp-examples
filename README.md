# c-sharp-examples
C# programs source-codes developed to serve as examples for a C# Introduction presentation, for the Programming Language 
discipline of the Information Systems undergraduate course, at the Federal Institute of Alagoas.  

// 

Códigos-fonte de programas em C# desenvolvidos para servirem de exemplo para a apresentação de Introdução ao C#, da 
disciplina de Linguagem de Programação do curso de graduação em Sistemas de Informação, do Instituto Federal de Alagoas


## Como executar
---

Existem algumas maneiras de executar código em C#. Uma delas é por meio de linha de comando, utilizando o compilador csc.exe, incluído no SDK do .NET:

### Requisitos 

- Instale o [.NET](https://dotnet.microsoft.com/pt-br/download) (dotnet) 
    - Teste a instalação digitando ``dotnet --version`` em uma aba de terminal.
    - Qual é a diferença entre .NET Framework e .NET Core?  
        A .NET Core é uma solução mais leve e modular que o .NET Framework e pode ser usada em diferentes sistemas operacionais como Windows, Mac e Linux. A Framework só funciona nativo em Windows.


-  Instale uma ferramenta de edição de texto. Recomenda-se o [Visual Studio Code](https://code.visualstudio.com/), que oferece algumas extensões como:
    -  C# (Microsoft) 
        ![Extensão oficial](https://i.stack.imgur.com/MRbxU.png)
    -  C# Extensions (jchannon): Facilita a codificação ao oferecer opções de sintaxe clicando com o botão direito do mouse no arquivo.
         ![Extensão recomendada](https://miro.medium.com/v2/resize:fit:1400/1*UDt5DsnR9DsgolRS1jGueQ.png)
        ![Clica no botão esquerdo do mouse no arquivo e terá essas opções de sintaxe prontas](https://www.macoratti.net/21/01/vs_codext15.jpg)
        
### Windows
1. Configurar o compilador  
    Após a instalação do .NET, deve-se adicionar o caminho do diretório que contém os executáveis, inclusive o compilador, ao PATH (nas variáveis de ambiente do sistema)

2. Compilar o código-fonte  
    - Abrir uma aba de terminal
    - Entrar no diretório CSharpExamples, que contém os arquivos .cs
    - Executar ``csc /main:CSharpExamples.NomeClasse NomePrograma.cs``, substituindo NomeClasse e NomePrograma pelos respectivos nomes da classe e programa a serem executados.  
    Esse comando cria um .exe no mesmo diretório em que foi executado.
3. Executar o programa
	- ``NomeDoPrograma.exe`` ou ``./NomeDoPrograma.exe`` (PowerShell)


## Sugestões de Leitura

- [Como instalar e configurar o C# no Vs Code](https://youtu.be/S5HawDwjuUY)
