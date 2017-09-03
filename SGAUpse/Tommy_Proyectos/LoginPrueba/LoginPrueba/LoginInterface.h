#pragma once
#include "AccCreate.h"


namespace LoginPrueba {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	

	/// <summary>
	/// Summary for LoginInterface
	/// </summary>
	public ref class LoginInterface : public System::Windows::Forms::Form
	{
	public:
		LoginInterface(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~LoginInterface()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  login;
	private: System::Windows::Forms::Button^  crearcuenta;

	protected:


	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  usuario;
	private: System::Windows::Forms::TextBox^  password;


	private: System::Windows::Forms::Label^  label3;
	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->login = (gcnew System::Windows::Forms::Button());
			this->crearcuenta = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->usuario = (gcnew System::Windows::Forms::TextBox());
			this->password = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// login
			// 
			this->login->Location = System::Drawing::Point(215, 178);
			this->login->Name = L"login";
			this->login->Size = System::Drawing::Size(107, 23);
			this->login->TabIndex = 0;
			this->login->Text = L"Log In";
			this->login->UseVisualStyleBackColor = true;
			this->login->Click += gcnew System::EventHandler(this, &LoginInterface::button1_Click);
			// 
			// crearcuenta
			// 
			this->crearcuenta->AccessibleRole = System::Windows::Forms::AccessibleRole::Window;
			this->crearcuenta->Location = System::Drawing::Point(215, 207);
			this->crearcuenta->Name = L"crearcuenta";
			this->crearcuenta->Size = System::Drawing::Size(107, 23);
			this->crearcuenta->TabIndex = 1;
			this->crearcuenta->Text = L"Crear Cuenta";
			this->crearcuenta->UseVisualStyleBackColor = true;
			this->crearcuenta->Click += gcnew System::EventHandler(this, &LoginInterface::button2_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(48, 82);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(46, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Usuario:";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(48, 112);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(64, 13);
			this->label2->TabIndex = 3;
			this->label2->Text = L"Contraseña:";
			this->label2->Click += gcnew System::EventHandler(this, &LoginInterface::label2_Click);
			// 
			// usuario
			// 
			this->usuario->Location = System::Drawing::Point(128, 79);
			this->usuario->Name = L"usuario";
			this->usuario->Size = System::Drawing::Size(134, 20);
			this->usuario->TabIndex = 4;
			this->usuario->TextChanged += gcnew System::EventHandler(this, &LoginInterface::usuario_TextChanged);
			// 
			// password
			// 
			this->password->Location = System::Drawing::Point(128, 109);
			this->password->Name = L"password";
			this->password->Size = System::Drawing::Size(134, 20);
			this->password->TabIndex = 5;
			this->password->TextChanged += gcnew System::EventHandler(this, &LoginInterface::password_TextChanged);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Yu Gothic UI Semibold", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->ForeColor = System::Drawing::SystemColors::WindowFrame;
			this->label3->Location = System::Drawing::Point(20, 9);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(291, 28);
			this->label3->TabIndex = 6;
			this->label3->Text = L"Sistema de Gestión Académica";
			this->label3->Click += gcnew System::EventHandler(this, &LoginInterface::label3_Click);
			// 
			// LoginInterface
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(334, 261);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->password);
			this->Controls->Add(this->usuario);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->crearcuenta);
			this->Controls->Add(this->login);
			this->Name = L"LoginInterface";
			this->Text = L"LoginInterface";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void label2_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void label3_Click(System::Object^  sender, System::EventArgs^  e) {
	}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
	AccCreate^frm = gcnew AccCreate;
	frm->Show(this);
}
private: System::Void usuario_TextChanged(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void password_TextChanged(System::Object^  sender, System::EventArgs^  e) {
}
};
}
