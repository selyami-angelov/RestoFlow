import useAxios from 'axios-hooks'
import { FormEventHandler, MouseEventHandler, useContext, useEffect, useState } from 'react'

import { AuthContext } from '../../context/AuthContext'
import { API_ENDPOINTS } from '../../common/api-endpoints'
import { isValidEmail } from '../../utils/email-validation'
import { DEFAULT_STATES, ERROR_MESSAGES, VALIDATION_MESSAGES } from '../../common/constants'

interface FormDataProps {
  email: string
  password: string
}

interface ErrorsProps {
  email?: string
  password?: string
}

export const Login = () => {
  const [formData, setFormData] = useState<FormDataProps>(DEFAULT_STATES.FORM)
  const [errors, setErrors] = useState<ErrorsProps>(DEFAULT_STATES.ERRORS)
  const [responseError, setResponseError] = useState('')
  const { dispatch } = useContext(AuthContext)
  const [{ data, error, loading }, executePost] = useAxios(
    {
      url: API_ENDPOINTS.LOGIN,
      method: 'POST',
    },
    { manual: true }
  )

  const onInput: FormEventHandler<HTMLInputElement> = (event) => {
    const key = event.currentTarget.name.trim() as keyof FormDataProps
    const value = event.currentTarget.value.trim()
    setErrors((prevState) => ({ ...prevState, [key]: '' }))
    setFormData((prevState) => ({ ...prevState, [key]: value }))
  }

  const handleLoginClick: MouseEventHandler<HTMLButtonElement> = (event) => {
    event.preventDefault()
    const validationErrors = { ...DEFAULT_STATES.ERRORS }
    if (!formData.email) {
      validationErrors.email = VALIDATION_MESSAGES.EMAIL
    } else if (!isValidEmail(formData.email)) {
      validationErrors.email = VALIDATION_MESSAGES.EMAIL_REGEX
    }
    if (!formData.password) {
      validationErrors.password = VALIDATION_MESSAGES.PASSWORD
    }

    setErrors(validationErrors)
    if (!validationErrors.email && !validationErrors.password) {
      const postData = {
        email: formData.email,
        password: formData.password,
      }
      executePost({
        data: postData,
      })
    }
  }

  useEffect(() => {
    if (data) {
      dispatch({ type: 'LOGIN', payload: data })
    }
  }, [data, dispatch])

  useEffect(() => {
    if (error?.response && error?.response?.status === 400) {
      setResponseError(ERROR_MESSAGES.LOGIN)
    }
  }, [error])

  return (
    <section className="bg-gray-50 dark:bg-gray-900 h-full">
      <div className="flex flex-col items-center justify-center h-full">
        <div className="w-full bg-white rounded-lg shadow dark:border md:mt-0 sm:max-w-md xl:p-0 dark:bg-gray-800 dark:border-gray-700">
          <div className="p-6 space-y-4 md:space-y-6 sm:p-8">
            <h1 className="text-xl font-bold leading-tight tracking-tight text-gray-900 md:text-2xl dark:text-white">
              Sign in to your account
            </h1>
            <form className="space-y-4 md:space-y-6" action="#">
              <div>
                <label htmlFor="email" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
                  Your email
                </label>
                <input
                  value={formData?.email}
                  onInput={onInput}
                  type="email"
                  name="email"
                  id="email"
                  className="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  placeholder="name@company.com"
                  required
                />
                {errors.email && <p className="text-sm text-red-500">{errors.email}</p>}
              </div>
              <div>
                <label htmlFor="password" className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
                  Password
                </label>
                <input
                  value={formData?.password}
                  onInput={onInput}
                  type="password"
                  name="password"
                  id="password"
                  placeholder="••••••••"
                  className="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  required
                />
                {errors.password && <p className="text-sm text-red-500">{errors.password}</p>}
              </div>
              <button
                type="submit"
                onClick={handleLoginClick}
                disabled={Boolean(errors.email || errors.password)}
                className={`w-full text-white bg-primary-600 hover:bg-primary-700 focus:ring-4 focus:outline-none focus:ring-primary-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-primary-600 dark:hover:bg-primary-700 dark:focus:ring-primary-800 ${
                  errors.email || errors.password ? 'opacity-50 cursor-not-allowed' : ''
                }`}
              >
                Sign in
              </button>
              <p className="text-sm font-light text-gray-500 dark:text-gray-400">
                Don’t have an account yet?{' '}
                <a href="#" className="font-medium text-primary-600 hover:underline dark:text-primary-500">
                  Sign up
                </a>
              </p>
            </form>

            {responseError && (
              <div
                className="p-4 mb-4 text-sm text-red-800 rounded-lg bg-red-50 dark:bg-gray-800 dark:text-red-400"
                role="alert"
              >
                {responseError}
              </div>
            )}
          </div>
        </div>
      </div>
    </section>
  )
}
