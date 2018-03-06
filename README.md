# EF6 Sugar

Nowadays Entity Framework 6 offers lots of syntax sugar and lots of convention-over-configuration stuff. What I have shown so far is the way a developer can create its own way how to generate:

* custom c# code on Add-Migration <name>
* custom SQL scripts on Update-Database

Add-Migration <name> adds a named .cs file which is the blueprint of the migration. We can create a  custom c# code generator to provide customizations of our generated code. We need to inherit the CSharpMigrationCodeGenerator  class and do its own implementation. It has lots of 'Generate' methods which are overridable and can be used to put custom logic. It's registered in the constructor of the Configuration.cs like this.CodeGenerator = new OurCustomCodeGenerator();

Update-Database creates a SQL script if there is the flag -Script or automatically does SQL schema compare based on the generated SQL script. We can apply some customization over the generation of this SQL as we inherit and implement the SqlServerMigrationSqlGenerator class. It has lots of 'Generate' methods which are overridable and can be used to put custom logic. It's registered as     SetSqlGenerator("System.Data.SqlClient", new CustomMigrationsProviders.CustomSqlServerMigrationSqlGenerator()); in the constructor of the Configuration.cs
