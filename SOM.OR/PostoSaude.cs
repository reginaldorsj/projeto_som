using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class PostoSaude
	{
		

		
		#region Private Members		

		private long? _id_posto_saude; 
		private string _nome; 
		private bool _ativo; 		
		#endregion

		
		
		#region Constructor

		public PostoSaude()
		{
			_id_posto_saude = null; 
			_nome = null;
			_ativo = false;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdPostoSaude
		{
			get
			{ 
				return _id_posto_saude;
			}
			set
			{
				_id_posto_saude = value;
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
			
		public virtual bool Ativo
		{
			get
			{ 
				return _ativo;
			}
			set
			{
				_ativo = value;
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
			PostoSaude castObj = (PostoSaude)obj; 
			return ( castObj != null ) &&
				( this._id_posto_saude == castObj.IdPostoSaude );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_posto_saude.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
