using System.Collections.Generic;

namespace AboutMe.Models
{
    public static class NavigatorManager
    {
        public static readonly List<NavigatorElement> NavigatorElements = new()
        {
            new NavigatorElement
            {
                Path = "/",
                Name = "About Me"
            },
            new NavigatorElement
            {
                Path = "/projects",
                Name = "Projects"
            },
            new NavigatorElement
            {
                Path = "/blog",
                Name = "Blog"
            }
        };

        public static readonly List<NavigatorElement> AboutMeNavigatorElements = new()
        {
            new NavigatorElement
            {
                Path = "/",
                Name = "General"
            },
            new NavigatorElement
            {
                Path = "/about-me/education",
                Name = "Education"
            },
            new NavigatorElement
            {
                Path = "/about-me/professional",
                Name = "Professional"
            },
            new NavigatorElement
            {
                Path = "/about-me/language",
                Name = "Language"
            },
            new NavigatorElement
            {
                Path = "/about-me/programming language",
                Name = "Programming Language"
            },
            new NavigatorElement
            {
                Path = "/about-me/other-education",
                Name = "Other Education"
            },
            new NavigatorElement
            {
                Path = "/about-me/hobbies",
                Name = "Hobbies"
            }
        };
    }
}