using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Ocupacao
	{
		

		
		#region Private Members		

		private long? _id_ocupacao; 
		private string _codigo; 
		private string _nome; 		
		#endregion

		
		
		#region Constructor

		public Ocupacao()
		{
			_id_ocupacao = null; 
			_codigo = null;
			_nome = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdOcupacao
		{
			get
			{ 
				return _id_ocupacao;
			}
			set
			{
				_id_ocupacao = value;
			}

		}
			

		public virtual string Codigo
		{
			get
			{ 
				return _codigo;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Codigo'");
				
				if(  value.Length > 6)
					throw new ExceptionRS("Valor ultrapassa limite em 'Codigo'");					

				_codigo = value;
			}
		}
			
		public virtual string Nome
		{
			get
			{ 
				return _nome;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Nome'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Nome'");					

				_nome = value;
			}
		}
			
		#endregion 
		
		
		#region Public Functions

		#endregion

		
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			Ocupacao castObj = (Ocupacao)obj; 
			return ( castObj != null ) &&
				( this._id_ocupacao == castObj.IdOcupacao );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_ocupacao.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
