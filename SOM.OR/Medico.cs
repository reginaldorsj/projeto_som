using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Medico
	{
		

		
		#region Private Members		

		private long? _id_medico; 
		private string _cremeb; 
		private Uf _id_uf; 
		private string _nome; 		
		#endregion

		
		
		#region Constructor

		public Medico()
		{
			_id_medico = null; 
			_cremeb = null;
			_id_uf = null; 
			_nome = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdMedico
		{
			get
			{ 
				return _id_medico;
			}
			set
			{
				_id_medico = value;
			}

		}
			


		public virtual string Cremeb
		{
			get
			{ 
				return _cremeb;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Cremeb'");
				
				if(  value.Length > 7)
					throw new ExceptionRS("Valor ultrapassa limite em 'Cremeb'");					

				_cremeb = value;
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
			Medico castObj = (Medico)obj; 
			return ( castObj != null ) &&
				( this._id_medico == castObj.IdMedico );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_medico.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
