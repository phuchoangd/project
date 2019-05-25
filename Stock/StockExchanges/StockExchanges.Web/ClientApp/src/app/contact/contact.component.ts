import { Component, OnInit } from '@angular/core';
import { IContactModel } from '../models/contact-model';
import { FormsModule }    from '@angular/forms';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  public message: string;
  public errorMessage: string;
  public contactName: string;
  public contactEmail:string;
  public contactSubject:string;
  public contactMessage:string;
  constructor() { }

  ngOnInit() {
  }
  sendContact() {
    if (this.contactEmail && this.contactName && this.contactMessage){
      this.errorMessage = "";
      this.message = "Thanks your feedback!";
      this.resetForm();
    }
    else{
      this.message="";
      this.errorMessage = "Please enter input fields!";
    }
  }

  resetForm(){
    this.contactName = "";
    this.contactEmail = "";
    this.contactSubject = "";
    this.contactMessage = "";
  }

}
