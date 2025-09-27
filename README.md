📱 Sistema de Celulares em C#
📖 Descrição

Este projeto faz parte do desafio da trilha .NET da DIO e tem como objetivo praticar os conceitos de Programação Orientada a Objetos (POO), como abstração, herança e polimorfismo, através da modelagem de um sistema que representa diferentes celulares.

🎯 Objetivo do Desafio

Modelar uma classe abstrata Smartphone e implementar classes concretas (Nokia e iPhone), respeitando as regras do diagrama fornecido e aplicando corretamente os pilares da POO.

📌 Regras e Validações

✅ A classe Smartphone deve ser abstrata, não podendo ser instanciada diretamente.
✅ As classes Nokia e iPhone devem herdar de Smartphone.
✅ O método InstalarAplicativo deve ser sobrescrito em cada classe filha, pois cada celular possui sua própria forma de instalar aplicativos.
✅ O programa deve seguir o diagrama de classes proposto e os trechos com // TODO devem ser implementados para completar a solução.

🛠️ Estrutura do Projeto

O sistema é composto pelas seguintes classes:

Smartphone (abstrata)

Propriedades: Numero, Modelo, IMEI, Memoria

Métodos: Ligar(), ReceberLigacao(), InstalarAplicativo(string nomeApp) (abstrato)

Nokia (herda de Smartphone)

Implementa InstalarAplicativo de forma específica para Nokia.

iPhone (herda de Smartphone)

Implementa InstalarAplicativo de forma específica para iPhone.

🚀 Tecnologias Utilizadas

C#

.NET 6+

Programação Orientada a Objetos (POO)

📦 Como Executar o Projeto

Clone o repositório:

git clone https://github.com/Alan-RiBas/trilha-net-poo-desafio[https://github.com/Alan-RiBas/trilha-net-poo-desafio]


Acesse a pasta do projeto:

cd sistema-celulares


Execute o projeto com o .NET CLI:

dotnet run

🏆 Desafio DIO

Projeto desenvolvido como parte do módulo Orientação a Objetos com C# da Digital Innovation One
.