﻿using NUnit.Framework;
using Tests.Build.build_instruction_emitter.contexts;

namespace Tests.Build.build_instruction_emitter
{
    public class output_assembly_with_doc : msbuild_emitter
    {
        public output_assembly_with_doc()
        {
            given_export_name("bin-net35");
            given_output("sauron.dll");
            given_output("sauron.xml");
            when_generating_instructions();
        }

        [Test]
        public void doc_is_exported()
        {
            should_have_file("bin-net35", "sauron.xml");
        }

        [Test]
        public void assembly_is_exported()
        {
            should_have_file("bin-net35", "sauron.dll");
        }
    }
}