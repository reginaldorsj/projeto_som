using System;
using Regisoft;
using System.Collections.Generic ;

namespace SOM.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Paciente
	{
		

		
		#region Private Members		

		private long? _id_paciente; 
		private string _nome; 
		private string _endereco; 
		private string _bairro; 
		private Municipio _id_municipio; 
		private Raca _id_raca; 
		private Sexo _id_sexo; 
		private int _idade; 
		private string _telefone; 		
		#endregion

		
		
		#region Constructor

		public Paciente()
		{
			_id_paciente = null; 
			_nome = null;
			_endereco = null;
			_bairro = null;
			_id_municipio = null; 
			_id_raca = null; 
			_id_sexo = null; 
			_idade = 0;
			_telefone = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdPaciente
		{
			get
			{ 
				return _id_paciente;
			}
			set
			{
				_id_paciente = value;
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
			
		public virtual string Endereco
		{
			get
			{ 
				return _endereco;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Endereco'");					

				_endereco = value;
			}
		}
			
		public virtual string Bairro
		{
			get
			{ 
				return _bairro;
			}

			set	
			{	
				if(  value != null &&  value.Length > 72)
					throw new ExceptionRS("Valor ultrapassa limite em 'Bairro'");					

				_bairro = value;
			}
		}
			
		public virtual Municipio IdMunicipio
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
			
		public virtual Raca IdRaca
		{
			get
			{ 
				return _id_raca;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdRaca'");

				_id_raca = value;
			}

		}
			
		public virtual Sexo IdSexo
		{
			get
			{ 
				return _id_sexo;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdSexo'");

				_id_sexo = value;
			}

		}
			
		public virtual int Idade
		{
			get
			{ 
				return _idade;
			}
			set
			{
				_idade = value;
			}

		}
			
		public virtual string Telefone
		{
			get
			{ 
				return _telefone;
			}

			set	
			{	
				if(  value != null &&  value.Length > 14)
					throw new ExceptionRS("Valor ultrapassa limite em 'Telefone'");					

				_telefone = value;
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
			Paciente castObj = (Paciente)obj; 
			return ( castObj != null ) &&
				( this._id_paciente == castObj.IdPaciente );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_paciente.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
