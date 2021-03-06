using NUnit.Framework;
using OpenWrap.Commands.Cli.Locators;
using OpenWrap.Testing;
using Tests.Commands.contexts;

namespace Tests.Commands.command_line_locators.default_verb
{
    class one_default_verb : command_locator<DefaultVerbCommandLocator>
    {
        public one_default_verb() : base(_ => new DefaultVerbCommandLocator(_))
        {
            given_command("get", "help", command => command.IsDefault = true);
            when_executing("help");
        }

        [Test]
        public void command_is_selected()
        {
            command_should_be("get", "help");
        }
        [Test]
        public void command_line_is_cleared()
        {
            ResultingLine.ShouldBeEmpty();
        }
    }
}