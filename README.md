<p align="center"><img src="docs/Capa-ApiGateway.png" alt="Capa do projeto APIGateway" width="100%" /></p>

<h1 align="center">🌐 API Gateway</h1>

<p align="center"><em>Proxy reverso ASP.NET Core com YARP e autenticação JWT.</em></p>

<p align="center">🇧🇷 Português | 🇺🇸 <a href="README.en.md">English</a></p>

<p align="center"><img src="https://img.shields.io/badge/licen%C3%A7a-MIT-006bed?style=flat-square" alt="MIT" /> <img src="https://img.shields.io/github/last-commit/Felipe-Amorim-Dev/APIGateway?style=flat-square&color=006bed" alt="Last commit" /></p>

<p align="center"><a href="#sobre">Sobre</a> • <a href="#tecnologias">Tecnologias</a> • <a href="#como-rodar">Como rodar</a> • <a href="#licenca">Licença</a> • <a href="#autor">Autor</a></p>

---

<a id="sobre"></a>
## 📖 Sobre

Gateway em .NET 8 que utiliza YARP para direcionar chamadas HTTP a serviços configurados. Inclui validação JWT Bearer e endpoint de demonstração de geração de token. As rotas e clusters são definidos nas configurações da aplicação.

## ✨ Funcionalidades

- Encaminhamento de rotas pelo YARP
- Validação de token JWT
- Endpoint de demonstração de autenticação

## 🛠️ Tecnologias

![C#](https://img.shields.io/badge/C%23-006bed?style=for-the-badge) ![.NET 8](https://img.shields.io/badge/.NET_8-006bed?style=for-the-badge) ![YARP 2.3.0](https://img.shields.io/badge/YARP_2.3.0-006bed?style=for-the-badge) ![JWT](https://img.shields.io/badge/JWT-006bed?style=for-the-badge) ![Swagger](https://img.shields.io/badge/Swagger-006bed?style=for-the-badge) ![Docker](https://img.shields.io/badge/Docker-006bed?style=for-the-badge)

## 📦 Pré-requisitos

SDK .NET 8. Configure `Jwt__Key` e os destinos dos serviços locais.

<a id="como-rodar"></a>
## 🚀 Como rodar

```bash
git clone https://github.com/Felipe-Amorim-Dev/APIGateway.git
cd APIGateway
dotnet restore APIGateWay.sln
dotnet build APIGateWay.sln
dotnet run --project APIGateWay.API
```

<a id="licenca"></a>
## 📄 Licença

Distribuído sob a [licença MIT](LICENSE).

<a id="autor"></a>
## 👤 Autor

**Felipe Figueiredo Amorim** — Desenvolvedor Full Stack.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Felipe%20Amorim-0A66C2?style=for-the-badge&logo=linkedin)](https://www.linkedin.com/in/felipe-amorim-dev/) [![E-mail](https://img.shields.io/badge/E--mail-contato-006bed?style=for-the-badge)](mailto:felipe.f.amorim@outlook.com)

<p align="center"><strong>Obrigado por visitar! / Thanks for visiting!</strong></p>
