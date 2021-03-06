public partial class Processor
{
    public virtual bool TargetAssemblyHasAlreadyBeenProcessed()
    {
        if (ContainsTypeChecker.Check(AssemblyFilePath, "ProcessedByFody"))
        {
            Logger.LogDebug("Did not process because file has already been processed.");
            return true;
        }
        return false;
    }
}