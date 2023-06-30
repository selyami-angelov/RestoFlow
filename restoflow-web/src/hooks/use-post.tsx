import { AxiosRequestConfig } from 'axios'
import useAxios from 'axios-hooks'

type URL = string

export const usePost = <T,>(url?: URL) => {
  const [{ data, error, loading }, executePost] = useAxios<T>({
    url,
    method: 'POST',
  })

  const postData = (data: unknown, url?: string) => {
    executePost({ data, url })
  }

  return { data: data ?? [], error, loading, postData }
}
