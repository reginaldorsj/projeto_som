using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Carnaval
	{
		

		
		#region Private Members		

		private long? _id_carnaval; 
		private int _ano; 
		private bool _ativo; 
		private DateTime _data_hora_encerramento; 		
		#endregion

		
		
		#region Constructor

		public Carnaval()
		{
			_id_carnaval = null; 
			_ano = 0;
			_ativo = false;
			_data_hora_encerramento = Convert.ToDateTime("1/1/1800");
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdCarnaval
		{
			get
			{ 
				return _id_carnaval;
			}
			set
			{
				_id_carnaval = value;
			}

		}
			

		public virtual int Ano
		{
			get
			{ 
				return _ano;
			}
			set
			{
				_ano = value;
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
			
		public virtual DateTime DataHoraEncerramento
		{
			get
			{ 
				return _data_hora_encerramento;
			}
			set
			{
				_data_hora_encerramento = value;
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
			Carnaval castObj = (Carnaval)obj; 
			return ( castObj != null ) &&
				( this._id_carnaval == castObj.IdCarnaval );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_carnaval.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
