#pragma once

namespace LoginPrueba {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for AccCreate
	/// </summary>
	public ref class AccCreate : public System::Windows::Forms::Form
	{
	public:
		AccCreate(void)
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
		~AccCreate()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  crear;
	protected:

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
			this->crear = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// crear
			// 
			this->crear->Location = System::Drawing::Point(197, 226);
			this->crear->Name = L"crear";
			this->crear->Size = System::Drawing::Size(75, 23);
			this->crear->TabIndex = 0;
			this->crear->Text = L"Crear";
			this->crear->TextAlign = System::Drawing::ContentAlignment::MiddleRight;
			this->crear->UseVisualStyleBackColor = true;
			this->crear->Click += gcnew System::EventHandler(this, &AccCreate::button1_Click);
			// 
			// AccCreate
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 261);
			this->Controls->Add(this->crear);
			this->Name = L"AccCreate";
			this->Text = L"AccCreate";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	};
}
