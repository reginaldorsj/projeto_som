using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class EscalaMedico
	{
		

		
		#region Private Members		

		private long? _id_escala_medico; 
		private Unidade _id_unidade; 
		private Ocupacao _id_ocupacao; 
		private Medico _id_medico; 
		private DateTime _data_hora_inicio; 
		private DateTime _data_hora_fim; 		
		#endregion

		
		
		#region Constructor

		public EscalaMedico()
		{
			_id_escala_medico = null; 
			_id_unidade = null; 
			_id_ocupacao = null; 
			_id_medico = null; 
			_data_hora_inicio = Convert.ToDateTime("1/1/1800");
			_data_hora_fim = Convert.ToDateTime("1/1/1800");
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdEscalaMedico
		{
			get
			{ 
				return _id_escala_medico;
			}
			set
			{
				_id_escala_medico = value;
			}

		}
			
		public virtual Unidade IdUnidade
		{
			get
			{ 
				return _id_unidade;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdUnidade'");

				_id_unidade = value;
			}

		}
			
		public virtual Ocupacao IdOcupacao
		{
			get
			{ 
				return _id_ocupacao;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdOcupacao'");

				_id_ocupacao = value;
			}

		}
			
		public virtual Medico IdMedico
		{
			get
			{ 
				return _id_medico;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdMedico'");

				_id_medico = value;
			}

		}
			
		public virtual DateTime DataHoraInicio
		{
			get
			{ 
				return _data_hora_inicio;
			}
			set
			{
				_data_hora_inicio = value;
			}

		}
			
		public virtual DateTime DataHoraFim
		{
			get
			{ 
				return _data_hora_fim;
			}
			set
			{
				_data_hora_fim = value;
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
			EscalaMedico castObj = (EscalaMedico)obj; 
			return ( castObj != null ) &&
				( this._id_escala_medico == castObj.IdEscalaMedico );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_escala_medico.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
