﻿using NUnit.Framework;
using OpenWrap;
using OpenWrap.Commands.Wrap;
using Tests.Commands.contexts;
using Tests.Commands.update_wrap.project;

namespace Tests.Commands.update_wrap.system
{
    public class from_remote: contexts.update_wrap
    {
        public from_remote()
        {
            given_project_package("goldberry", "2.0.0");
            given_system_package("goldberry", "2.1.0");
            given_remote_package("goldberry", "2.2.0");
            
            when_executing_command("-system");
        }
        [Test]
        public void project_repo_not_updated()
        {
            Environment.ProjectRepository.ShouldHavePackage("goldberry","2.0.0");
        }

        [Test]
        public void system_repo_updated()
        {
            Environment.SystemRepository.ShouldHavePackage("goldberry", "2.2.0");            
        }
    }
}