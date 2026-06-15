using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Agents.Shakespearean {
    public static class ShakespeareanTools {
        public static AIFunction GetDictionaryTool()
            => AIFunctionFactory.Create(GetShakespeareanDictionary);

        [Description(
            "Returns a curated dictionary of authentic Shakespearean and Elizabethan English words " +
            "together with their modern meanings. Call this tool to enrich a rewritten poem with " +
            "period-accurate vocabulary before producing the final output.")]
        public static string GetShakespeareanDictionary() {
            var words = new Dictionary<string, string> {
                ["thee"] = "you (object form, e.g. 'I love thee')",
                ["thou"] = "you (subject form, e.g. 'thou art brave')",
                ["thy"] = "your (e.g. 'thy name')",
                ["thine"] = "yours / your (before a vowel, e.g. 'thine eyes')",
                ["hath"] = "has (third-person singular, e.g. 'he hath spoken')",
                ["doth"] = "does (third-person singular, e.g. 'she doth protest')",
                ["art"] = "are (e.g. 'thou art my light')",
                ["wherefore"] = "why (e.g. 'wherefore art thou Romeo?' means 'why are you Romeo?')",
                ["ere"] = "before (poetic, e.g. 'ere the sun sets')",
                ["methinks"] = "it seems to me (e.g. 'methinks the lady doth protest too much')",
                ["forsooth"] = "indeed / in truth (e.g. 'forsooth, it is a wondrous sight')",
                ["perchance"] = "perhaps / possibly (e.g. 'perchance to dream')",
                ["alas"] = "an exclamation of grief or pity (e.g. 'alas, poor Yorick')",
                ["hence"] = "from this place / from now (e.g. 'get thee hence')",
                ["hark"] = "listen / pay attention (e.g. 'hark! what light through yonder window breaks')"
            };

            return string.Join("\n", words.Select(kv => $"- **{kv.Key}**: {kv.Value}"));
        }
    }
}
