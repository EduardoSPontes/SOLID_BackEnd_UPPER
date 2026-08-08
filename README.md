#  Desafio Upper - Princípios SOLID

Projeto desenvolvido durante o curso da **Upper**, com o objetivo de praticar e compreender os cinco princípios do **SOLID** utilizando **C#** e **.NET**.

##  Sobre o projeto

Neste desafio foram implementados exemplos simples para demonstrar cada um dos cinco princípios do SOLID.

Os exemplos utilizam situações com **animais**, facilitando a compreensão da diferença entre uma implementação que viola o princípio e uma implementação que segue o princípio corretamente.

Cada princípio possui duas partes:

- `Solucao` → exemplo aplicando corretamente o princípio.
- `Violacao` → exemplo demonstrando uma implementação que não segue o princípio.

---

##  Princípios SOLID

###  S - Single Responsibility Principle (SRP)

**Princípio da Responsabilidade Única**

Uma classe deve possuir apenas uma responsabilidade.

No projeto, o exemplo utiliza um cachorro para demonstrar a separação de responsabilidades entre a classe do animal e seus comportamentos.

---

###  O - Open/Closed Principle (OCP)

**Princípio Aberto/Fechado**

Uma classe deve estar aberta para extensão, mas fechada para modificação.

O exemplo demonstra como adicionar novos animais sem precisar modificar as classes existentes.

---

###  L - Liskov Substitution Principle (LSP)

**Princípio da Substituição de Liskov**

Classes derivadas devem poder substituir suas classes base sem alterar o funcionamento esperado do programa.

O exemplo utiliza animais para demonstrar uma situação que viola esse princípio e uma solução adequada.

---

###  I - Interface Segregation Principle (ISP)

**Princípio da Segregação de Interfaces**

Uma classe não deve ser obrigada a implementar métodos que não utiliza.

O exemplo demonstra a separação das interfaces de emissão de som e voo, permitindo que cada animal implemente apenas o que realmente necessita.

---

###  D - Dependency Inversion Principle (DIP)

**Princípio da Inversão de Dependência**

As classes devem depender de abstrações, e não diretamente de implementações.

No projeto, a classe `Fazenda` utiliza a interface `IAnimal` em vez de depender diretamente da classe `Cachorro`.



