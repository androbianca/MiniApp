import { Component, OnInit } from '@angular/core';
import { Singer } from 'src/app/components/singer/singer.model';
import { FormGroup, FormControl } from '@angular/forms';
import { SingerService } from '../singer.service';

@Component({
  selector: 'app-add-singer',
  templateUrl: './add-singer.component.html',
  styleUrls: ['./add-singer.component.scss']
})
export class AddSingerComponent implements OnInit {
  singerForm: FormGroup;
  singer= new Singer();
  
  constructor(public singerService:SingerService) { }

  ngOnInit(): void {
    this.initForm();
  }

  initForm(): void {
    this.singerForm = new FormGroup({
      name: new FormControl(''),
      musictype: new FormControl(''),
    })
  }

  submit(): void {
    this.singer.name = this.singerForm.get('name').value;
    this.singer.musicType = this.singerForm.get('musictype').value;

    this.singerService.add(this.singer).subscribe();
  }

}
