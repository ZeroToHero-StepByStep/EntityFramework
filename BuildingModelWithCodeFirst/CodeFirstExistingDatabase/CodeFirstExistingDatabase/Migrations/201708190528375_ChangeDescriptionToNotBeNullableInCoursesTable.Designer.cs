// <auto-generated />
namespace CodeFirstExistingDatabase.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class ChangeDescriptionToNotBeNullableInCoursesTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(ChangeDescriptionToNotBeNullableInCoursesTable));
        
        string IMigrationMetadata.Id
        {
            get { return "201708190528375_ChangeDescriptionToNotBeNullableInCoursesTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}