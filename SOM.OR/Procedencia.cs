using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Procedencia
	{
		

		
		#region Private Members		

		private long? _id_procedencia; 
		private string _descricao; 
		private bool _ativo; 		
		#endregion

		
		
		#region Constructor

		public Procedencia()
		{
			_id_procedencia = null; 
			_descricao = null;
			_ativo = false;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdProcedencia
		{
			get
			{ 
				return _id_procedencia;
			}
			set
			{
				_id_procedencia = value;
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
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Descricao'");					

				_descricao = value;
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
			Procedencia castObj = (Procedencia)obj; 
			return ( castObj != null ) &&
				( this._id_procedencia == castObj.IdProcedencia );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_procedencia.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
