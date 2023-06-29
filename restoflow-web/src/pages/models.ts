export interface LoginFormProps {
  email: string
  password: string
}

export interface RegisterFormProps extends LoginFormProps {
  firstName: string
  lastName: string
  confirmPassword: string
}

export type LoginErrorsProps = Partial<LoginFormProps>
export type RegisterErrorsProps = Partial<RegisterFormProps>
