using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Municipio
	{
		

		
		#region Private Members		

		private long? _id_municipio; 
		private Uf _id_uf; 
		private string _descricao; 
		private string _codigo_ibge; 		
		#endregion

		
		
		#region Constructor

		public Municipio()
		{
			_id_municipio = null; 
			_id_uf = null; 
			_descricao = null;
			_codigo_ibge = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdMunicipio
		{
			get
			{ 
				return _id_municipio;
			}
			set
			{
				_id_municipio = value;
			}

		}
			

		public virtual Uf IdUf
		{
			get
			{ 
				return _id_uf;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdUf'");

				_id_uf = value;
			}

		}
			
		public virtual string Descricao
		{
			get
			{ 
				return _descricao;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Descricao'");
				
				if(  value.Length > 40)
					throw new ExceptionRS("Valor ultrapassa limite em 'Descricao'");					

				_descricao = value;
			}
		}
			
		public virtual string CodigoIbge
		{
			get
			{ 
				return _codigo_ibge;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'CodigoIbge'");
				
				if(  value.Length > 20)
					throw new ExceptionRS("Valor ultrapassa limite em 'CodigoIbge'");					

				_codigo_ibge = value;
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
			Municipio castObj = (Municipio)obj; 
			return ( castObj != null ) &&
				( this._id_municipio == castObj.IdMunicipio );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_municipio.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
