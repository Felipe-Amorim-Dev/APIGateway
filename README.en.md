<p align="center"><img src="docs/Capa-ApiGateway.png" alt="Project cover APIGateway" width="100%" /></p>

<h1 align="center">🌐 API Gateway</h1>

<p align="center"><em>ASP.NET Core reverse proxy with YARP and JWT authentication.</em></p>

<p align="center">🇧🇷 <a href="README.md">Português</a> | 🇺🇸 English</p>

<p align="center"><img src="https://img.shields.io/badge/license-MIT-006bed?style=flat-square" alt="MIT" /> <img src="https://img.shields.io/github/last-commit/Felipe-Amorim-Dev/APIGateway?style=flat-square&color=006bed" alt="Last commit" /></p>

<p align="center"><a href="#sobre">About</a> • <a href="#tecnologias">Technologies</a> • <a href="#como-rodar">Running locally</a> • <a href="#licenca">License</a> • <a href="#autor">Author</a></p>

---

<a id="sobre"></a>
## 📖 About

NET 8 gateway using YARP to route HTTP requests to configured services. Includes JWT bearer validation and a demonstration endpoint for token generation. Routes and clusters are configured through application settings.

## ✨ Features

- YARP route forwarding
- JWT token validation
- Demonstration authentication endpoint

## 🛠️ Technologies

![C#](https://img.shields.io/badge/C%23-006bed?style=for-the-badge) ![.NET 8](https://img.shields.io/badge/.NET_8-006bed?style=for-the-badge) ![YARP 2.3.0](https://img.shields.io/badge/YARP_2.3.0-006bed?style=for-the-badge) ![JWT](https://img.shields.io/badge/JWT-006bed?style=for-the-badge) ![Swagger](https://img.shields.io/badge/Swagger-006bed?style=for-the-badge) ![Docker](https://img.shields.io/badge/Docker-006bed?style=for-the-badge)

## 📦 Prerequisites

.NET 8 SDK. Configure `Jwt__Key` and your own downstream destinations.

<a id="como-rodar"></a>
## 🚀 Running locally

```bash
git clone https://github.com/Felipe-Amorim-Dev/APIGateway.git
cd APIGateway
dotnet restore APIGateWay.sln
dotnet build APIGateWay.sln
dotnet run --project APIGateWay.API
```

<a id="licenca"></a>
## 📄 License

Distributed under the [MIT license](LICENSE).

<a id="autor"></a>
## 👤 Author

**Felipe Figueiredo Amorim** — Full Stack Developer.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Felipe%20Amorim-0A66C2?style=for-the-badge&logo=linkedin)](https://www.linkedin.com/in/felipe-amorim-dev/) [![E-mail](https://img.shields.io/badge/E--mail-contato-006bed?style=for-the-badge)](mailto:felipe.f.amorim@outlook.com)

<p align="center"><strong>Obrigado por visitar! / Thanks for visiting!</strong></p>
