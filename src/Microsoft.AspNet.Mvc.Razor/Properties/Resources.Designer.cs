// <auto-generated />
namespace Microsoft.AspNet.Mvc.Razor
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Mvc.Razor.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// The layout view '{0}' could not be located.
        /// </summary>
        internal static string LayoutCannotBeLocated
        {
            get { return GetString("LayoutCannotBeLocated"); }
        }

        /// <summary>
        /// The layout view '{0}' could not be located.
        /// </summary>
        internal static string FormatLayoutCannotBeLocated(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LayoutCannotBeLocated"), p0);
        }

        /// <summary>
        /// The 'inherits' keyword is not allowed when a '{0}' keyword is used.
        /// </summary>
        internal static string MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword
        {
            get { return GetString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword"); }
        }

        /// <summary>
        /// The 'inherits' keyword is not allowed when a '{0}' keyword is used.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_CannotHaveModelAndInheritsKeyword(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword"), p0);
        }

        /// <summary>
        /// The '{0}' keyword must be followed by a type name on the same line.
        /// </summary>
        internal static string MvcRazorCodeParser_ModelKeywordMustBeFollowedByTypeName
        {
            get { return GetString("MvcRazorCodeParser_ModelKeywordMustBeFollowedByTypeName"); }
        }

        /// <summary>
        /// The '{0}' keyword must be followed by a type name on the same line.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_ModelKeywordMustBeFollowedByTypeName(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_ModelKeywordMustBeFollowedByTypeName"), p0);
        }

        /// <summary>
        /// Only one '{0}' statement is allowed in a file.
        /// </summary>
        internal static string MvcRazorCodeParser_OnlyOneModelStatementIsAllowed
        {
            get { return GetString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed"); }
        }

        /// <summary>
        /// Only one '{0}' statement is allowed in a file.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_OnlyOneModelStatementIsAllowed(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed"), p0);
        }

        /// <summary>
        /// {0} can only be called from a layout page.
        /// </summary>
        internal static string RenderBodyCannotBeCalled
        {
            get { return GetString("RenderBodyCannotBeCalled"); }
        }

        /// <summary>
        /// {0} can only be called from a layout page.
        /// </summary>
        internal static string FormatRenderBodyCannotBeCalled(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RenderBodyCannotBeCalled"), p0);
        }

        /// <summary>
        /// {0} must be called from a layout page.
        /// </summary>
        internal static string RenderBodyNotCalled
        {
            get { return GetString("RenderBodyNotCalled"); }
        }

        /// <summary>
        /// {0} must be called from a layout page.
        /// </summary>
        internal static string FormatRenderBodyNotCalled(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RenderBodyNotCalled"), p0);
        }

        /// <summary>
        /// Section '{0}' is already defined.
        /// </summary>
        internal static string SectionAlreadyDefined
        {
            get { return GetString("SectionAlreadyDefined"); }
        }

        /// <summary>
        /// Section '{0}' is already defined.
        /// </summary>
        internal static string FormatSectionAlreadyDefined(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SectionAlreadyDefined"), p0);
        }

        /// <summary>
        /// {0} has already been called for the section named '{1}'.
        /// </summary>
        internal static string SectionAlreadyRendered
        {
            get { return GetString("SectionAlreadyRendered"); }
        }

        /// <summary>
        /// {0} has already been called for the section named '{1}'.
        /// </summary>
        internal static string FormatSectionAlreadyRendered(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SectionAlreadyRendered"), p0, p1);
        }

        /// <summary>
        /// Section '{0}' is not defined.
        /// </summary>
        internal static string SectionNotDefined
        {
            get { return GetString("SectionNotDefined"); }
        }

        /// <summary>
        /// Section '{0}' is not defined.
        /// </summary>
        internal static string FormatSectionNotDefined(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SectionNotDefined"), p0);
        }

        /// <summary>
        /// The following sections have been defined but have not been rendered: '{0}'.
        /// </summary>
        internal static string SectionsNotRendered
        {
            get { return GetString("SectionsNotRendered"); }
        }

        /// <summary>
        /// The following sections have been defined but have not been rendered: '{0}'.
        /// </summary>
        internal static string FormatSectionsNotRendered(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SectionsNotRendered"), p0);
        }

        /// <summary>
        /// View '{0}' must have extension '{1}' when the view represents a full path.
        /// </summary>
        internal static string ViewMustEndInExtension
        {
            get { return GetString("ViewMustEndInExtension"); }
        }

        /// <summary>
        /// View '{0}' must have extension '{1}' when the view represents a full path.
        /// </summary>
        internal static string FormatViewMustEndInExtension(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewMustEndInExtension"), p0, p1);
        }

        /// <summary>
        /// The method '{0}' cannot be invoked by this view.
        /// </summary>
        internal static string View_MethodCannotBeCalled
        {
            get { return GetString("View_MethodCannotBeCalled"); }
        }

        /// <summary>
        /// The method '{0}' cannot be invoked by this view.
        /// </summary>
        internal static string FormatView_MethodCannotBeCalled(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("View_MethodCannotBeCalled"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
