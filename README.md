# GestãoUnidadeSocorroMaui

Este projeto é uma aplicação desenvolvida com .NET MAUI para gerir diferentes unidades de socorro, como bombeiros, enfermeiros e médicos. O sistema organiza e permite a gestão de utilizadores, ocorrências e responsabilidades, utilizando conceitos de Programação Orientada a Objetos, como interfaces e herança, para criar uma estrutura modular, flexível e escalável.

## Índice

- [Descrição do Projeto](#descrição-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Instalação](#instalação)
- [Uso](#uso)

- [Licença](#licença)

---

## Descrição do Projeto

A aplicação de **Gestão de Unidades de Socorro** foi concebida para simplificar a gestão de operações de socorro, fornecendo uma estrutura onde diferentes tipos de utilizadores (bombeiros, enfermeiros, médicos) podem ser geridos e executarem ações específicas, como responder a ocorrências ou realizar treinamentos.

## Funcionalidades

- **Gestão de Utilizadores**: Criação e gestão de utilizadores (bombeiros, enfermeiros, médicos) com características e responsabilidades específicas.
- **Responder a Ocorrências**: Cada tipo de utilizador pode responder a ocorrências com ações específicas.
- **Gestão de Equipamentos**: Controlo de inspeções e manutenção de equipamentos de socorro.
- **Escalabilidade e Modularidade**: Utilização de interfaces para facilitar a expansão do sistema com novos tipos de utilizadores e funcionalidades sem modificar o código base.

## Estrutura do Projeto

A estrutura do projeto está organizada em pastas para facilitar a manutenção e expansão:

- **Models**: Contém as classes de dados principais, como `Utilizador`, `Bombeiro`, `Enfermeiro`, `Médico` e `Paramédico`, além das interfaces `IResponderOcorrencia`, `ITreinamento`, `IGerenciarEquipamento`.
- **ViewModels**: Implementa a lógica de ligação entre os Models e as Views, permitindo a gestão de dados e comandos.
- **Views**: Definições das interfaces gráficas que interagem com os utilizadores.
- **Services**: Serviços de backend, como manipulação de dados ou processamento de ocorrências.
- **Resources**: Recursos adicionais, como estilos e imagens.

## Tecnologias Utilizadas

- **.NET MAUI**: Plataforma para o desenvolvimento de aplicações multiplataforma.
- **C#**: Linguagem de programação usada para a implementação da lógica de negócio.

## Instalação

1. **Pré-requisitos**: Certifique-se de que tens o .NET MAUI e o SDK do .NET 7 ou superior instalados.
2. **Clone o repositório**:
   ```bash
   git clone https://github.com/Sixtapt/GestaoUnidadeSocorroMaui.git
   cd GestaoUnidadeSocorroMaui
