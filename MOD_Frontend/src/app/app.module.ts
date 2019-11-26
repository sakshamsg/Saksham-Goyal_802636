import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { CoursesComponent } from './courses/courses.component';
import { AboutComponent } from './about/about.component';
import { HomepageComponent } from './homepage/homepage.component';
import { UloginComponent } from './ulogin/ulogin.component';
import { UsignComponent } from './usign/usign.component';
import { UdashComponent } from './udash/udash.component';
import { MsignComponent } from './msign/msign.component';
import { UprofComponent } from './uprof/uprof.component';
import { MprofComponent } from './mprof/mprof.component';
import { ComptrComponent } from './comptr/comptr.component';
import { CrnttrComponent } from './crnttr/crnttr.component';
import { FindtrComponent } from './findtr/findtr.component';
import { ConctusComponent } from './conctus/conctus.component';
import { StudentService } from './_Services/student.service';
import { MentorService } from './_Services/mentor.service';
import { AdmindashComponent } from './admindash/admindash.component';
import { AdminStudentComponent } from './admin-student/admin-student.component';
import { AdminMentorComponent } from './admin-mentor/admin-mentor.component';
import { AdmintechComponent } from './admintech/admintech.component';
import { SearchComponent } from './search/search.component';
import { MdashComponent } from './mdash/mdash.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    CoursesComponent,
    AboutComponent,
    HomepageComponent,
    UloginComponent,
    UsignComponent,
    UdashComponent,
    MsignComponent,
    UprofComponent,
    MprofComponent,
    ComptrComponent,
    CrnttrComponent,
    FindtrComponent,
    ConctusComponent,
    AdmindashComponent,
    AdminStudentComponent,
    AdminMentorComponent,
    AdmintechComponent,
    SearchComponent,
    MdashComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [StudentService, MentorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
