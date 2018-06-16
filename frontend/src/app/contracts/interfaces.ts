interface UserProfile {
  profileId: number;
  firstName: string;
  firstNameEng: string;
  middleName: string;
  lastName: string;
  lastNameEng: string;
  birthday: Date;
  email: string;
  rank: string;
  deptId: number;
  group: string;
  room: string;
  domenName: string;
  employmentDate: Date;
  image: string;
  phone: string;
  skype: string;
}

interface LoginResponse {
  SessionId: number;
  ExtensionData: any;
  ErrorCode: string;
  Permission: string;
}

