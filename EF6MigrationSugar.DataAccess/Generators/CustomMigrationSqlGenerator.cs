namespace EF6MigrationSugar.DataAccess.Generators
{
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Migrations.Utilities;
    using System.Data.Entity.SqlServer;

    /// <summary>
    /// A custom migration SQL generator which is used on Update-Database
    /// </summary>
    internal class CustomMigrationSqlGenerator : SqlServerMigrationSqlGenerator
    {
        protected override void WriteCreateTable(CreateTableOperation createTableOperation, IndentedTextWriter writer)
        {
            writer.WriteLine($"-- Creating {createTableOperation.Name} table with {createTableOperation.Columns.Count} colums");
            base.WriteCreateTable(createTableOperation, writer);
        }
    }
}
