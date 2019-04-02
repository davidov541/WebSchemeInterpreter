using System;

using Scheme;

namespace Scheme
{

    public partial class _Default : System.Web.UI.Page
    {

        Interpreter inter = new Interpreter();
        /// <summary>
        /// Passes new text in txtConsole to Interpreter in order to be parsed into an XML Document.
        /// </summary>
        /// <param name="sender">Object with a reference to txtConsole.</param>
        /// <param name="e">Eventargs parameter referring to arguments specific to the TextChanged action.</param>
        protected void txtConsole_TextChanged(object sender, EventArgs e)
        {
            inter.convertForScheme(txtConsole.Text);
            lblOutput.Text = inter.representList(inter.Code);
            txtConsole.Text = "";
            txtConsole.Focus();
        }
    }
}