using Humanizer;
namespace Capitalizer
{
    public class CapitalizerPlugin : Plugin.Common.ITextPlugin
    {
        //public string TransformText(string input) => input.ToUpper(); //stare
        public string TransformText(string input) => input.Pascalize();
    }
}