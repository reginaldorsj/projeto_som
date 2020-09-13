using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Unidade
	{
		

		
		#region Private Members		

		private long? _id_unidade; 
		private string _nome; 
		private string _sigla; 
		private string _cor; 
		private bool _ativo; 		
		#endregion

		
		
		#region Constructor

		public Unidade()
		{
			_id_unidade = null; 
			_nome = null;
			_sigla = null;
			_cor = null;
			_ativo = false;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdUnidade
		{
			get
			{ 
				return _id_unidade;
			}
			set
			{
				_id_unidade = value;
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
			
		public virtual string Sigla
		{
			get
			{ 
				return _sigla;
			}

			set	
			{	
				if(  value != null &&  value.Length > 15)
					throw new ExceptionRS("Valor ultrapassa limite em 'Sigla'");					

				_sigla = value;
			}
		}
			
		public virtual string Cor
		{
			get
			{ 
				return _cor;
			}

			set	
			{	
				if(  value != null &&  value.Length > 6)
					throw new ExceptionRS("Valor ultrapassa limite em 'Cor'");					

				_cor = value;
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
			Unidade castObj = (Unidade)obj; 
			return ( castObj != null ) &&
				( this._id_unidade == castObj.IdUnidade );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_unidade.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
