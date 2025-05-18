# CashFlow – Personal Expense Management API 💰

<br> 
<p align="center">
  <a href="#-about-the-project">About the project</a> •
  <a href="#-technologies">Technologies</a> •  
  <a href="#-features">Features</a> •
  <a href="#-getting-started">Getting started</a> •
  <a href="#-routes">Routes</a> •
  <a href="#-license">License</a> 
</p>

## 👩‍💻 About the project

This **API**, built with **.NET 8**, adopts **Domain-Driven Design (DDD)** principles to provide a structured solution for personal expense management. Users can register expenses with details like title, date, description, amount, and payment type (securely stored in **MySQL**), and generate PDF/Excel reports for financial analysis. The RESTful architecture uses standard HTTP methods and includes interactive **Swagger** documentation.

## 🚀 Technologies

* [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [Entity Framework](https://learn.microsoft.com/en-us/ef/)
* [MySQL](https://www.mysql.com/)
* [Swagger](https://swagger.io/)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://docs.fluentvalidation.net/en/latest/)
* [FluentAssertions](https://fluentassertions.com/)

## ✨ Features

* **Domain-Driven Design (DDD)**: Modular structure for clear domain management.
* **Unit Testing**: Comprehensive tests with FluentAssertions for reliability.
* **Report Generation**: Export detailed expense reports to **PDF and Excel**.
* **RESTful API with Swagger**: Interactive documentation for seamless integration.

## 💻 Getting Started

### Requirements

- .NET 8 SDK  
- MySQL Server  
- (Optional) Visual Studio 2022+ or Visual Studio Code

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/leandrorodrigues00/CashFlow.git
    cd CashFlow
    ```
2. Configure your connection string and other settings in `appsettings.Development.json`.
3. Run the API:
    ```bash
    dotnet restore
    dotnet run
    ```
4. Access Swagger UI at `http://localhost:5000/swagger` to explore and test endpoints.

## 📝 License

This project is licensed under the MIT License – see the [LICENSE](LICENSE) file for details.

---

<p align="center">
  Made with 💜 by Leandro Rodrigues
</p>
