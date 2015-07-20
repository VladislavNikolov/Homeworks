namespace CohesionAndCoupling.Utilities
{
    public static class ExtensionMethods
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension;
            if (indexOfLastDot == -1)
            {
                extension = "No extension found.";

                return extension;
            }

            extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            string fileNameWithoutExtension;
            if (indexOfLastDot == -1)
            {
                fileNameWithoutExtension = fileName;

                return fileNameWithoutExtension;
            }

            fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);

            return fileNameWithoutExtension;
        }
    }
}
