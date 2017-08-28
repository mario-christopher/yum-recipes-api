# yum-recipes-api
**yum-recipes-api** is a simple web application built using :
* ASP.NET Core 2.0 WebApi - *to handle the server stuff.*
* EntityFrameworkCore 2.0
* [Sqlite](https://www.sqlite.org/index.html) - *used for data storage.*
* This app is the server-api end for the [yup-recipes](https://github.com/mario-christopher/yup-recipes) frontend (TBD).


## Setup
* `git clone https://github.com/mario-christopher/yum-recipes-api.git`
* `cd yum-recipes-api`
* Open the solution file `YumRecipes.sln` in VisualStudio 2017.
* Set the `Api` project as the startup project.
* Build solution and make sure it restores packages and builds the solution without errors.
* Open Package Manager Console and make sure that the `Repository` project is selected as the Default project.
* Run `Add-Migration InitialCreate` in the console to initiate the database migration. A Migrations folder will be created.
* Run `Update-Database` to create the database. A `YumRecipes.db` Sqlite database will be created under the Api folder.
* *Optional* - Install [Sqlite Browser](http://sqlitebrowser.org/), a GUI tool, to open and browse the created database.
* Run the solution (F5).
* Open a browser window and enter the url `http://localhost:8080/api/tags`. You should get an empty array `[]` as a response (as there is no data yet in the database).


##  Application features:

* Built using .Net Core 2.0 and EntityFrameowrkCore 2.0
* Uses **Repository Pattern** to separate database and API concerns.
* A generic Reposity service is used to handle current and future database actions without any further changes necessary.
* `Code First` approach is used with EntityFrameworkCore 2.0
* A `BaseModel` class is used for the Models (Code First Approach) to cover the common table attributes.
* `DataAnnotations` are used on the Columns/Properties to enhance validation and meaning to the tables.
* All the `Controllers` use Dependency Injection to get the Repository concrete classes.
* The Dependency Injection is chained further to instantiate the `DBContext` also in the Repository Service.
* The ConnectionString is picked up from the Configuration defined in the `appsettings.json` file.
* The `Controller` actions are implemented asynchronously using the **async/await** operators.
* Model Validation is implemented using a `FilterAttribute` class. This is a cross-cutting requirement for the project.

##   License

Shared under MIT License.