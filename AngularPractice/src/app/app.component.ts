import { Component, AfterViewInit } from '@angular/core';
import { SampleService } from './sample/sample.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements AfterViewInit {
  
  constructor(private sample: SampleService) { }

  ngAfterViewInit(): void {
    this.sample.sharedData.next("Data From Main App Module!");
  }

}
