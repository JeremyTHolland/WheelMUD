﻿//-----------------------------------------------------------------------------
// <copyright file="DefaultCommandsListRenderer.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team.  See LICENSE.txt.  This file is 
//   subject to the Microsoft Public License.  All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace WheelMUD.Core
{
    using System.Collections.Generic;
    using System.Text;
    using WheelMUD.Interfaces;

    [RendererExports.CommandsList(0)]
    public class DefaultCommandsListRenderer : RendererDefinitions.CommandsList
    {
        public override string Render(ITerminal terminal, IEnumerable<Command> commands, string categoryName)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<%yellow%>{categoryName} commands<%n%>:");
            foreach (var command in commands)
            {
                sb.AppendLine($"<%mxpsecureline%><send \"help {command.Name}\">{command.Name.PadRight(15)}</send> {command.Description}");
            }
            return sb.ToString();
        }
    }
}
