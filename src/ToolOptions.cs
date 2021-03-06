/*******************************************************************************************************************************
 * PFX Tool
 * Copyright (C) 2019 Aashish Koirala <https://www.aashishkoirala.com>
 *
 * This file is part of PFXTool.
 *
 * PFXTool is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * PFXTool is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with PFXTool.  If not, see <http://www.gnu.org/licenses/>.
 *
 *******************************************************************************************************************************/

using System.Security.Cryptography.X509Certificates;

namespace AK.PfxTool
{
	internal class ToolOptions
	{
		public const string MachineScope = "machine";
		public const string UserScope = "user";

		public string Command { get; set; }
		public string File { get; set; }
		public string Store { get; set; } = StoreName.My.ToString();
		public string Scope { get; set; } = MachineScope;
		public string Password { get; set; }
		public string Thumbprint { get; set; }
		public string CertFile { get; set; }
		public string KeyFile { get; set; }
	}
}