using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Delegate |
        AttributeTargets.Enum |
        AttributeTargets.Event |
        AttributeTargets.Field |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Module |
        AttributeTargets.Parameter |
        AttributeTargets.GenericParameter |
        AttributeTargets.Property |
        AttributeTargets.Struct)]
    class CodeStateAttribute:Attribute
    {
        #region Public properties
        public string CodeVersion { get; set; }
        public bool IsDefectFix { get; set; }
        public bool IsEvolution { get; set; }
        public bool IsRegularCode { get; set; }
        public String Author { get; set; }
        public String ResolvedBy { get; set; }
        public String ResolvedOn { get; set; }
        public String Comments { get; set; }
        public CodeStateAttribute(String codeVersion, bool isDefectFix, bool isEvolution, bool isRegularCode,
                                  String author, String resolvedBy, String resolvedOn, String comments)
        {
            CodeVersion = codeVersion;
            IsDefectFix = isDefectFix;
            IsEvolution = isEvolution;
            IsRegularCode = isRegularCode;
            Author = author;
            ResolvedBy = resolvedBy;
            ResolvedOn = resolvedOn;
            Comments = comments;
        }

        public CodeStateAttribute(String codeVersion, String author, String resolvedBy, String resolvedOn, String comments)
        :this(codeVersion,false, false, true, author, resolvedBy, resolvedOn, comments) {


        }
        #endregion

    }
}
