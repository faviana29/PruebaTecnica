# Proyecto: Aplicación Angular con API en .NET

Este proyecto consiste en una aplicación web desarrollada en **Angular** y una **API en .NET Core** que se conectan a una base de datos SQL Server para mostrar información paginada de una tabla `Clientes`. La aplicación cumple con los siguientes objetivos:

1. Mostrar datos de la tabla `Clientes` en una tabla HTML, incluyendo el formato del campo "teléfono".
2. Exponer dos servicios en la API:
   - Uno utilizando un procedimiento almacenado.
   - Otro utilizando LINQ con Entity Framework Core.
3. Implementar pruebas unitarias para validar las funcionalidades críticas.

---

## Requisitos Previos

### **Tecnologías Utilizadas**
- **Frontend**: Angular 10+
- **Backend**: .NET 6+
- **Base de Datos**: SQL Server
- **Pruebas Unitarias**:
  - **Angular**: Jasmine y Karma
  - **.NET**: NUnit o similar (opcional)

### **Herramientas Necesarias**
- [Node.js](https://nodejs.org) (versión 14+)
- [Angular CLI](https://angular.io/cli)
- [Visual Studio Code](https://code.visualstudio.com) o cualquier IDE para Angular.
- [Visual Studio](https://visualstudio.microsoft.com) para la API .NET.
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) para manejar la base de datos.

---

## Configuración y Ejecución del Proyecto

### **1. Clonar el Repositorio**

```bash
git clone https://github.com/faviana29/pruebatecnica.git
cd proyecto-angular-dotnet
