
using System;
using System.Collections.Generic;
using System.Text;
using Regisoft;
using SOM.OR;
using SOM.BO;

namespace SOM
{
	/// <summary>
	/// Classe que gerencia o acesso aos BO's.
	/// Gerado por RSClass - Gerador de Classes.
	/// </summary>
	public class BOAccess
	{
		/// <summary>
		/// Inicializa o componente de acesso aos BO's. O acesso � feito sem a utiliza��o de servidor de aplica��o.
		/// </summary>
        protected static IBOFactory boFactory = new BOFactory();
		/// <summary>
		/// Esta classe n�o pode ser instanciada.
		/// </summary>
        private BOAccess() {}
		
        #region BOAccess Members		

		/// <summary>
		/// L� o componente de acesso aos BO's.
		/// </summary>
		/// <returns>O BOFactory.</returns>
        public static IBOFactory getBOFactory()
        {
            return boFactory;            
        }
		
        #endregion
		
    }
}
