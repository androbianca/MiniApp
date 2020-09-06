import { Component } from '@angular/core';
import { Singer } from 'src/app/shared/models/singer.model';
import { SingerService } from 'src/app/shared/services/singer.service';

@Component({
  selector: 'app-add-singer',
  templateUrl: './add-singer.component.html',
  styleUrls: ['./add-singer.component.scss']
})
export class AddSingerComponent {
  singer = new Singer();

  get isSubmitButtonDisabled() {
    return !(this.singer.musicType && this.singer.name)
  }

  constructor(public singerService:SingerService) { }

  onSubmit(): void {
    if(this.singer.musicType && this.singer.name) {
      this.singerService.add(this.singer).subscribe();
    }
  }
}
