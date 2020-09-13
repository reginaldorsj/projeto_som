using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Dia
	{
		

		
		#region Private Members		

		private long? _id_dia; 
		private Carnaval _id_carnaval; 
		private DateTime _data; 		
		#endregion

		
		
		#region Constructor

		public Dia()
		{
			_id_dia = null; 
			_id_carnaval = null; 
			_data = Convert.ToDateTime("1/1/1800");
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdDia
		{
			get
			{ 
				return _id_dia;
			}
			set
			{
				_id_dia = value;
			}

		}
			

		public virtual Carnaval IdCarnaval
		{
			get
			{ 
				return _id_carnaval;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdCarnaval'");

				_id_carnaval = value;
			}

		}
			
		public virtual DateTime Data
		{
			get
			{ 
				return _data;
			}
			set
			{
				_data = value;
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
			Dia castObj = (Dia)obj; 
			return ( castObj != null ) &&
				( this._id_dia == castObj.IdDia );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_dia.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
