import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdashComponent } from './mdash.component';

describe('MdashComponent', () => {
  let component: MdashComponent;
  let fixture: ComponentFixture<MdashComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdashComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdashComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
