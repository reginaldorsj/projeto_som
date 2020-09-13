using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Diagnostico
	{
		

		
		#region Private Members		

		private long? _id_diagnostico; 
		private Atendimento _id_atendimento; 
		private Doenca _id_doenca; 		
		#endregion

		
		
		#region Constructor

		public Diagnostico()
		{
			_id_diagnostico = null; 
			_id_atendimento = null; 
			_id_doenca = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdDiagnostico
		{
			get
			{ 
				return _id_diagnostico;
			}
			set
			{
				_id_diagnostico = value;
			}

		}
			
		public virtual Atendimento IdAtendimento
		{
			get
			{ 
				return _id_atendimento;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdAtendimento'");

				_id_atendimento = value;
			}

		}
			
		public virtual Doenca IdDoenca
		{
			get
			{ 
				return _id_doenca;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdDoenca'");

				_id_doenca = value;
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
			Diagnostico castObj = (Diagnostico)obj; 
			return ( castObj != null ) &&
				( this._id_diagnostico == castObj.IdDiagnostico );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_diagnostico.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
