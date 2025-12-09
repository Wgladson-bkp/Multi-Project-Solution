namespace Multi_Project_Solution.Common
{
    public interface ITemplateBase
    {
        string ProjectFolder { get; }
        string ProjectName { get; }
        string FrameworkVersion { get; }

        string FolderSchemaBase(string fwrkVersion);
    }
}
