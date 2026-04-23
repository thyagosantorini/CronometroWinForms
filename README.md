### 🚀 Cronômetro WinForms



Um cronômetro simples desenvolvido em **C#** com **Windows Forms** para praticar conceitos de lógica de programação e manipulação de tempo com Stopwatch.



#### 📋 Sobre o Projeto



Este projeto foi criado como parte de um "intensivão" de C# focado em dominar os componentes do Windows Forms e a aplicação do princípio **DRY** (Don't Repeat Yourself). O cronômetro permite iniciar, pausar e resetar o tempo com precisão de milissegundos.



#### ✨ Funcionalidades



* **Iniciar/Parar**: Controle total sobre a contagem do tempo.
* **Resetar**: Zera o cronômetro e prepara para uma nova contagem.
* **Interface Responsiva**: Os botões habilitam e desabilitam conforme o estado do cronômetro para evitar erros do usuário.
* **Alta Precisão**: Uso da classe System.Diagnostics.Stopwatch para garantir que o tempo seja real e não dependa apenas do ciclo do Timer da interface.



#### 🛠️ Tecnologias Utilizadas



* **Linguagem**: C#
* **Framework**: .NET 8 (ou a versão que você usou)
* **Interface**: Windows Forms (WinForms)





#### 🏗️ Refatoração e Boas Práticas



Durante o desenvolvimento, o código passou por um processo de limpeza para:



1. **Remover redundâncias:** Centralização da lógica de controle de botões em um método dedicado.
2. **Separação de Preocupações:** O Stopwatch cuida da lógica do tempo enquanto o Timer cuida apenas da atualização visual da tela.



#### 📸 Demonstração



!\[Screenshot do Projeto](images/screenshot.gif)

