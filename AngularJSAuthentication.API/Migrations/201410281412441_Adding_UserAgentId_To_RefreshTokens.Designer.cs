// <auto-generated />
namespace AngularJSAuthentication.API.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.0-30225")]
    public sealed partial class Adding_UserAgentId_To_RefreshTokens : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Adding_UserAgentId_To_RefreshTokens));
        
        string IMigrationMetadata.Id
        {
            get { return "201410281412441_Adding_UserAgentId_To_RefreshTokens"; }
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
