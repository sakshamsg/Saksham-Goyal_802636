import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UdashComponent } from './udash.component';

describe('UdashComponent', () => {
  let component: UdashComponent;
  let fixture: ComponentFixture<UdashComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UdashComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UdashComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
