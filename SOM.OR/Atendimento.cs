using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Atendimento
	{
		

		
		#region Private Members		

		private long? _id_atendimento; 
		private Dia _id_dia; 
		private Unidade _id_unidade; 
		private Procedencia _id_procedencia; 
		private PostoSaude _id_posto_saude; 
		private Origem _id_origem; 
		private string _hora; 
		private string _prontuario; 
		private Paciente _id_paciente; 
		private Medico _id_medico; 
		private Causa _id_causa; 
		private Procedimento _id_procedimento; 
		private TipoObito _id_tipo_obito; 
		private string _especificar_causa_obito; 
		private DateTime _data_inclusao; 
		private DateTime? _data_ultima_alteracao; 
		private DateTime? _data_exclusao; 		
		#endregion

		
		
		#region Constructor

		public Atendimento()
		{
			_id_atendimento = null; 
			_id_dia = null; 
			_id_unidade = null; 
			_id_procedencia = null; 
			_id_posto_saude = null; 
			_id_origem = null; 
			_hora = null;
			_prontuario = null;
			_id_paciente = null; 
			_id_medico = null; 
			_id_causa = null; 
			_id_procedimento = null; 
			_id_tipo_obito = null; 
			_especificar_causa_obito = null;
			_data_inclusao = Convert.ToDateTime("1/1/1800");
			_data_ultima_alteracao = null; 
			_data_exclusao = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdAtendimento
		{
			get
			{ 
				return _id_atendimento;
			}
			set
			{
				_id_atendimento = value;
			}

		}
			

		public virtual Dia IdDia
		{
			get
			{ 
				return _id_dia;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdDia'");

				_id_dia = value;
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
			
		public virtual Procedencia IdProcedencia
		{
			get
			{ 
				return _id_procedencia;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdProcedencia'");

				_id_procedencia = value;
			}

		}
			
		public virtual PostoSaude IdPostoSaude
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
			
		public virtual Origem IdOrigem
		{
			get
			{ 
				return _id_origem;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdOrigem'");

				_id_origem = value;
			}

		}
			
		public virtual string Hora
		{
			get
			{ 
				return _hora;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Hora'");
				
				if(  value.Length > 5)
					throw new ExceptionRS("Valor ultrapassa limite em 'Hora'");					

				_hora = value;
			}
		}
			
		public virtual string Prontuario
		{
			get
			{ 
				return _prontuario;
			}

			set	
			{	
				if(  value != null &&  value.Length > 10)
					throw new ExceptionRS("Valor ultrapassa limite em 'Prontuario'");					

				_prontuario = value;
			}
		}
			
		public virtual Paciente IdPaciente
		{
			get
			{ 
				return _id_paciente;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdPaciente'");

				_id_paciente = value;
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
			
		public virtual Causa IdCausa
		{
			get
			{ 
				return _id_causa;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdCausa'");

				_id_causa = value;
			}

		}
			
		public virtual Procedimento IdProcedimento
		{
			get
			{ 
				return _id_procedimento;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdProcedimento'");

				_id_procedimento = value;
			}

		}
			
		public virtual TipoObito IdTipoObito
		{
			get
			{ 
				return _id_tipo_obito;
			}
			set
			{
				_id_tipo_obito = value;
			}

		}
			
		public virtual string EspecificarCausaObito
		{
			get
			{ 
				return _especificar_causa_obito;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'EspecificarCausaObito'");					

				_especificar_causa_obito = value;
			}
		}
			
		public virtual DateTime DataInclusao
		{
			get
			{ 
				return _data_inclusao;
			}
			set
			{
				_data_inclusao = value;
			}

		}
			
		public virtual DateTime? DataUltimaAlteracao
		{
			get
			{ 
				return _data_ultima_alteracao;
			}
			set
			{
				_data_ultima_alteracao = value;
			}

		}
			
		public virtual DateTime? DataExclusao
		{
			get
			{ 
				return _data_exclusao;
			}
			set
			{
				_data_exclusao = value;
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
			Atendimento castObj = (Atendimento)obj; 
			return ( castObj != null ) &&
				( this._id_atendimento == castObj.IdAtendimento );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_atendimento.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
